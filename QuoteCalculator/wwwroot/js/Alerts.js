
// Prepare the webpage for alerts
$(document).ready(function() {
    hide_all_alerts();
});

// Handle close alerts
function close_alert(alert_id) {
    $('#' + alert_id).hide();
}

// Hide all alerts
function hide_all_alerts() {
    $('#alert_primary').hide();
    $('#alert_danger').hide();
    $('#alert_success').hide();
    $('#alert_warning').hide();
}

// function for handling alerts
function show_alert(message, type) {
    hide_all_alerts();
    var alert = document.getElementById("alert_" + type);
    alert.innerHTML = message +
        '<button type="button" class="close" aria-label="Close" onclick="close_alert(\'alert_' + type + '\')">' + 
        '<span aria-hidden="true">&times;</span>' +
        '</button>';
    $('#alert_' + type).fadeIn('slow');
    $('#alert_' + type).delay(10000).fadeOut('slow');
}
