<?php
// NOTE: This example uses the next generation Twilio helper library - for more
// information on how to download and install this version, visit
// https://www.twilio.com/docs/libraries/php
require_once '/path/to/vendor/autoload.php';

use Twilio\Rest\Client;

// Your Account SID and Auth Token from https://www.twilio.com/console
$accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
$authToken = "your_auth_token";

$serviceSid = "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

// Initialize the client
$client = new Client($accountSid, $authToken);

// Create a detailed notification
$notification = $client
    ->notify->services($serviceSid)
    ->notifications->create([
        "identity" => "00000001",
        "title" => "Generic loooooooong title for all Bindings",
        "body" => "This is the body for all Bindings",
        "fcm" => '{"notification":{"title":"New alert","body":"Hello Bob!"}}',
        "apn" => '{"aps":{"alert":{"title":"New alert","body":"Hello Bob!"}}}'
    ]);

echo $notification->body; // => This is the body for all Bindings
