// Download the Node helper library from twilio.com/docs/node/install
// These are your accountSid and authToken from https://www.twilio.com/console
const accountSid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX';
const authToken = 'your_auth_token';

const MonitorClient = require('twilio').MonitorClient;
const client = new MonitorClient(accountSid, authToken);

client.alerts.list(function(err, data) {
    data.alerts.forEach(function(alert) {
        console.log(alert.alertText);
    });
});
