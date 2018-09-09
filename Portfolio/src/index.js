const functions = require('firebase-functions');

const admin = require('firebase-admin');
admin.initializeApp(functions.config().firebase);

const SENDGRID_API_KEY = functions.config().sendgrid.key;
const MY_INBOX = functions.config().mails.myinbox;

const sgMail = require('@sendgrid/mail');
sgMail.setApiKey(SENDGRID_API_KEY);

// Create and Deploy Your First Cloud Functions
// https://firebase.google.com/docs/functions/write-firebase-functions

exports.sendMail = functions.https.onRequest((request, response) => {
    if (request.body) {
        const reqBody = request.body;
        console.log(request);
        const msg = {
            to: MY_INBOX,
            from: reqBody.email,
            subject: 'Enquiry via website from ' + reqBody.name,
            text: reqBody.message,
        };
        sgMail.send(msg).then(resp => {
            if (resp.statusCode === 200 || resp.statusCode === 201) {
                response.status(200).send("Successfully sent mail.");
            }
            else {
                response.status(resp.statusCode).send("Email was not sent due to erroneous status code from SendGrid.");
            }
        }).catch(error => {
            response.status(400).send("Email was not sent due to error in 3rd party email service." + error);
        });
    }
    else {
        response.status(400).send("Email was not sent");
    }
});
