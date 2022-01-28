
$(document).ready(function () {
    addOnClickListenerForSendRequestButton();
});

// Onclick Listeners
function addOnClickListenerForSendRequestButton() {
    $('#APIRequestModal_SendPostRequestButton').on("click", function () {
        var userJSON = $('#rawJSONRequestBodyTextArea').val();
        sendPOSTRequestToUserInquiry(userJSON);
    });
}

// Utility Functions
function sendPOSTRequestToUserInquiry(userJSON) {
    function successUserInquiry(userInquiryResponse) {
        $('#APIRequestModal').modal("hide");
        processUserInquiryResponse(userInquiryResponse);
    }

    function failedUserInquiry() {
        show_alert("POST REQUEST FAILED", "danger");
    }

    sendPOSTRequest("api/UserInquiry", userJSON, successUserInquiry, failedUserInquiry);
}

    function sendPOSTRequest(targetURL, requestData, successFunction, errorFunction) {
        setupAJAX();
        $.ajax({
            url: targetURL,
            contentType: 'application/json',
            type: 'POST',
            data: requestData,
            dataType: 'json',
            success: successFunction,
            error: errorFunction
        });
    }

function processUserInquiryResponse(userInquiryResponse) {
    window.location.href = getParentURLFrom(userInquiryResponse) + '?inquiryResponse=' + getResponseBodyFrom(userInquiryResponse);
}

function getParentURLFrom(userInquiryResponse) {
    return userInquiryResponse.headers.redirectedURL;
}

function getResponseBodyFrom(userInquiryResponse) {
    return JSON.stringify(userInquiryResponse);
}