function fb_login() {
    FB.login();
};

function fb_logout() {
    FB.logout();
};

function InitialiseFacebook(appId) {
    window.fbAsyncInit = function () {
        FB.init({
            appId: appId,
            status: true,
            cookie: true,
            xfbml: true
        });

        FB.Event.subscribe('auth.login', function (response) {
            var credentials = { uid: response.authResponse.userID, accessToken: response.authResponse.accessToken };
            SubmitLogin(credentials);
        });

        FB.Event.subscribe('auth.logout', function (response) {
            window.location.href = ("../home/logout");
        });

        FB.getLoginStatus(function (response) {
            if (response.status === 'connected') {
                if (window.location.href === 'http://simpleblog.duckdns.org/') { //vil kanskje heller kjøre et script i Index-viewet som ordner dette
                    var credentials = { uid: response.authResponse.userID, accessToken: response.authResponse.accessToken };
                    SubmitLogin(credentials);
                }
            }

            else if (response.status === 'not_authorized') { }
            else {
            }
        });

        function SubmitLogin(credentials) {
            $.ajax({
                url: "/home/facebooklogin",
                type: "POST",
                data: credentials,
                error: function () {
                    alert("could not log you into the application through facebook");
                },
                success: function () {
                    window.location.reload();
                }
            });
        }
    };

    (function (d) {
        var js, id = 'facebook-jssdk', ref = d.getElementsByTagName('script')[0];
        if (d.getElementById(id)) {
            return;
        }
        js = d.createElement('script');
        js.id = id;
        js.async = true;
        js.src = "//connect.facebook.net/en_US/all.js";
        ref.parentNode.insertBefore(js, ref);
    }(document));
}