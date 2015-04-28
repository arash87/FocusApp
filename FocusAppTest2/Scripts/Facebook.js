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
                if (window.location.href === 'http://localhost:55568/') { //vil heller kjøre et script i Index-viewet som gjør dette
                    alert("hei");
                    var credentials = { uid: response.authResponse.userID, accessToken: response.authResponse.accessToken };
                    SubmitLogin(credentials);
                }
            }
                //window.location.replace("home/inside");
                //alert("user is logged into fb");
            else if (response.status === 'not_authorized') { alert("user is not authorized"); }
            else {
            }
        });

        //function RedirectLogin(credentials) {
        //    $.ajax({
        //        url: "account/facebookredirect",
        //        type: "POST",
        //        data: credentials,
        //        success: function () {
        //            window.location.replace("home/inside");
        //        }
        //    });
        //}

        function SubmitLogin(credentials) {
            $.ajax({
                url: "/home/facebooklogin",
                type: "POST",
                data: credentials,
                error: function () {
                    alert("error logging in to your facebook account.");
                },
                success: function () {
                    window.location.replace("main/mycourses");
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