
$(document).ready(function () {
    addOnClickListenerForCalculateQuoteButton();
    addOnClickListenerforApplyNowButton();
    validateQuoteCalculatorForm();
    addValueChangeListenersForQuoteCalculatorForm();
});

// --------------- Core Calculations ---------------

var calculatedPMTData = {};

function adjustSlideLabel(percentage, minimumValueLabel, maximumValueLabel, stringPatternToRemove) {
    var minimumValue = parseInt(minimumValueLabel.innerText.replace(stringPatternToRemove, ""));
    var maximumValue = parseInt(maximumValueLabel.innerText.replace(stringPatternToRemove, ""));
    return calculateSlideValue(percentage, minimumValue, maximumValue);
}

    function calculateSlideValue(percentage, minimumValue, maximumValue) {
        if (percentage == null) percentage = 50;
        valueDifference = maximumValue - minimumValue;
        percentageDifference = Math.round(valueDifference * (percentage / 100));
        newSliderValue = minimumValue + percentageDifference;
        return newSliderValue;
    }

function startQuoteCalculationProcess() {
    getInputFromQuoteCalculatorForm();
}

    function getInputFromQuoteCalculatorForm() {
        var userInput = getUserInputFromQuoteCalculatorForm();
        var loanInput = getLoanInputFromQuoteCalculatorForm();

        updateQuotationResultsModalUserInfo(userInput);
        updateQuotationResultsModalFinancialInfo(loanInput);
    }
        
function startApplicationProcess() {
    loanApplicationRequestData = getLoanApplicationRequestData();
    sendPostRequestToApplyLoan(loanApplicationRequestData);
}

    function getLoanApplicationRequestData() {
        loanApplicationRequestData = {
            userInput: getUserInputFromQuoteCalculatorForm(),
            loanInput: getLoanInputFromQuoteCalculatorForm(),
            PMTData: calculatedPMTData
        }
        return loanApplicationRequestData;
}

    function sendPostRequestToApplyLoan(loanApplicationRequestData) {
        function successLoanApplication(LoanApplicationResponse) {
            if (LoanApplicationResponse.responseCode != 200) {
                show_alert("Error: " + LoanApplicationResponse.errorMessage, "danger");
            }
            else {
                window.location.href = "ApplicationStatus?loanId=" + LoanApplicationResponse.loanId;
            }
        }

        function failedLoanApplication() {
            show_alert("Something went wrong with the loan application.", "danger");
        }

        sendPOSTRequest("api/ApplyLoan", JSON.stringify(loanApplicationRequestData), successLoanApplication, failedLoanApplication);
        $('#QuotationResultsModal').modal('toggle');
    }

function getUserInputFromQuoteCalculatorForm() {
    var userInput = {
        "userTitle": getOptionalFieldValueFor("Title"),
        "userFirstName": $('#UserInquiryForm_FirstName').val(),
        "userLastName": $('#UserInquiryForm_LastName').val(),
        "userBirthDate": $('#UserInquiryForm_Birthdate').val(),
        "userMobile": $('#UserInquiryForm_Mobile').val(),
        "userEmail": $('#UserInquiryForm_Email').val(),
    }
    return userInput;
}

    function getOptionalFieldValueFor(fieldLabel) {
        var fieldValue = document.getElementById('UserInquiryForm_' + fieldLabel).innerHTML;
        if (fieldValue == fieldLabel) fieldValue = "";
        return fieldValue;
    }

function getLoanInputFromQuoteCalculatorForm() {
    var loanInput = {
        "LoanDuration": document.getElementById("LoanDurationSliderValue").innerText.replace(" month/s", ""),
        "RequestedAmount": document.getElementById("AmountRequiredSliderValue").innerText.replace("$", ""),
        "ProductName": document.getElementById("SelectedProduct").innerText
    }
    return loanInput;
}

// --------------- Front End Rendering -------------- 

function changeSelectedProduct(productName, productIcon, lowestLoanableAmount, highestLoanableAmount, minimumLoanDuration, maximumLoanDuration) {
    $("#selectedProductHeader").html('<span class="fas ' + productIcon + ' fa-2x"></span> <span id="SelectedProduct">' + productName + "</span>");
    changeAmountRequiredSliderValueOnProductSelection(lowestLoanableAmount, highestLoanableAmount);
    changeLoanDurationSliderValueOnProductSelection(minimumLoanDuration, maximumLoanDuration);
}

    function changeAmountRequiredSliderValueOnProductSelection(lowestLoanableAmount, highestLoanableAmount) {
        $("#AmountRequiredSlider_MinimumValueLabel").html("$" + lowestLoanableAmount);
        $('#AmountRequiredSlider_MaximumValueLabel').html("$" + highestLoanableAmount);
        var amountRequiredSelectedValue = document.getElementById("AmountRequiredSlider").value;
        document.getElementById("AmountRequiredSliderValue").innerHTML = "$" +
            adjustSlideLabel(amountRequiredSelectedValue, document.getElementById("AmountRequiredSlider_MinimumValueLabel"),
                document.getElementById("AmountRequiredSlider_MaximumValueLabel"), "$");
    }

    function changeLoanDurationSliderValueOnProductSelection(minimumLoanDuration, maximumLoanDuration) {
        var loanDurationSelectedValue = document.getElementById("LoanDurationSlider").value;
        $('#LoanDurationSlider_MinimumValueLabel').html(minimumLoanDuration + " month/s");
        $('#LoanDurationSlider_MaximumValueLabel').html(maximumLoanDuration + " month/s");
        document.getElementById("LoanDurationSliderValue").innerHTML =
            adjustSlideLabel(loanDurationSelectedValue, document.getElementById("LoanDurationSlider_MinimumValueLabel"),
                document.getElementById("LoanDurationSlider_MaximumValueLabel"), " month/s") + " month/s";
}

function addOnClickListenerForCalculateQuoteButton() {
    $('#CalculateQuoteButton').on("click", function () {
        startQuoteCalculationProcess();
    });
}

function addOnClickListenerforApplyNowButton() {
    $('#ApplyNowButton').on("click", function () {
        startApplicationProcess();
    });
}

function updateQuotationResultsModalUserInfo(userInput) {
    document.getElementById('QuotationResultsTable_FullName').innerHTML =
        userInput.userTitle + " " +
        userInput.userFirstName + " " +
        userInput.userLastName + " ";
    document.getElementById('QuotationResultsTable_BirthDate').innerHTML = userInput.userBirthDate;
    document.getElementById('QuotationResultsTable_Mobile').innerHTML = userInput.userMobile;
    document.getElementById('QuotationResultsTable_Email').innerHTML = userInput.userEmail;
}

    function updateQuotationResultsModalFinancialInfo(loanInput) {
        function successPMTFormula(PMTResponse) {
            calculatedPMTData = PMTResponse;
            document.getElementById('QuotationResultsTable_ChosenProduct').innerHTML = document.getElementById('selectedProductHeader').innerHTML;
            document.getElementById('QuotationResultsTable_FinanceAmount').innerHTML = "$" + PMTResponse.financeAmount;
            document.getElementById('QuotationResultsTable_LoanDuration').innerHTML = "<b>over " + PMTResponse.loanDuration + " months</b>";
            document.getElementById('QuotationResultsTable_Repayments').innerHTML = "$" + PMTResponse.repaymentsAmount;
            document.getElementById('QuotationResultsTable_TotalRepayments').innerHTML = "$" + PMTResponse.totalRepayments;
            $('#QuotationResultsTable_FreeInterestPeriod').hide();
            if (PMTResponse.freeInterestPeriod > 0) {
                document.getElementById('QuotationResultsTable_FreeInterestPeriod').innerHTML = "<b>Interest free for the first " + PMTResponse.freeInterestPeriod + " month/s</b>";
                $('#QuotationResultsTable_FreeInterestPeriod').show();
            }
        }

        function failedPMTFormula() {
            show_alert("Something went wrong with the PMT formula.", "danger");
        }

        sendPOSTRequest("api/PMTFormula", JSON.stringify(loanInput), successPMTFormula, failedPMTFormula);
}

// --------------- Server-side Validations -------------- 

function validateQuoteCalculatorForm() {
    $('#CalculateQuoteButton').attr('disabled', true);
    if (isValid('FirstName') && isValid('LastName') && isValid('Birthdate') && isValid('Mobile') && isValid('Email'))
        $('#CalculateQuoteButton').attr('disabled', false);
}

function isValid(inputField) {
    var inputValue = $('#UserInquiryForm_' + inputField).val();
    if (inputValue == '') {
        $('#UserInquiryForm_' + inputField).addClass('is-invalid');
        return false;
    }
    else {
        $('#UserInquiryForm_' + inputField).removeClass('is-invalid');
        return true;
    }
}

function addValueChangeListenersForQuoteCalculatorForm() {
    addValueChangeListenerFor('FirstName');
    addValueChangeListenerFor('LastName');
    addValueChangeListenerFor('Birthdate');
    addValueChangeListenerFor('Mobile');
    addValueChangeListenerFor('Email');

}

    function addValueChangeListenerFor(inputField) {
        $("#UserInquiryForm_" + inputField).on("change paste keyup", function () {
            validateQuoteCalculatorForm();
        });
    }