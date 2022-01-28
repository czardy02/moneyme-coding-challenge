
// Prepare the web page
$(document).ready(function () {
    setDefaultValueForRequestJSONTextArea();
    setDefaultValueForBirthdateDatePicker();
    setUpCarousel();
});

// Utility Functions
function setDefaultValueForRequestJSONTextArea() {
    var defaultInputRequestJSON = JSON.parse(DefaultUserInquiryRequestBody);
    if ($("#rawJSONRequestBodyTextArea").length == 0) return;
    document.getElementById("rawJSONRequestBodyTextArea").value = JSON.stringify(defaultInputRequestJSON, undefined, 4);
};

function setDefaultValueForBirthdateDatePicker() {
    const birthdateDatePicker = MCDatepicker.create({
        el: "#UserInquiryForm_Birthdate",
        context: document.getElementById("UserInquiryForm_Birthdate_Column"),
        dateFormat: "YYYY-MM-DD",
        showCalendarDisplay: false,
        customOkBTN: 'Pick Date',
        customClearBTN: 'Clear',
        customCancelBTN: 'Close',
        autoClose: false,
        bodyType: 'inline',
        selectedDate: new Date($('#UserInquiryForm_Birthdate').val())
    });
    $(".mc-calendar").css("z-index", 1600);
    $('#UserFormsModal').on('hidden.bs.modal', function (e) {
        birthdateDatePicker.close();
    });
    birthdateDatePicker.onSelect((date, formatedDate) => {
        $('#UserInquiryForm_Birthdate').removeClass('is-invalid');
    });
}

function setUserTitleAs(title) {
    $("#UserInquiryForm_Title").html(title)
}

function setupCarousel() {
    const myCarousel = document.querySelector('#myCarousel')
    const carousel = new mdb.Carousel(myCarousel)
}