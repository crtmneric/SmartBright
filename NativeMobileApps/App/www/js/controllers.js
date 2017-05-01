angular.module('starter.controllers', [])

.controller('AppCtrl', function($scope, $ionicModal, $timeout) {

  // With the new view caching in Ionic, Controllers are only called
  // when they are recreated or on app start, instead of every page change.
  // To listen for when this page is active (for example, to refresh data),
  // listen for the $ionicView.enter event:
  //$scope.$on('$ionicView.enter', function(e) {
  //});

  // Form data for the login modal
  $scope.loginData = {};

  // Create the login modal that we will use later
  $ionicModal.fromTemplateUrl('templates/login.html', {
    scope: $scope
  }).then(function(modal) {
    $scope.modal = modal;
  });

  // Triggered in the login modal to close it
  $scope.closeLogin = function() {
    $scope.modal.hide();
  };

  // Open the login modal
  $scope.login = function() {
    $scope.modal.show();
  };

  // Perform the login action when the user submits the login form
  $scope.doLogin = function() {
    console.log('Doing login', $scope.loginData);

    // Simulate a login delay. Remove this and replace with your login
    // code if using a login system
    $timeout(function() {
      $scope.closeLogin();
    }, 1000);
  };
})

.controller('PlaylistsCtrl', function($scope) {
  $scope.playlists = [
    { title: 'Reggae', id: 1 },
    { title: 'Chill', id: 2 },
    { title: 'Dubstep', id: 3 },
    { title: 'Indie', id: 4 },
    { title: 'Rap', id: 5 },
    { title: 'Cowbell', id: 6 }
  ];
})

.controller('PlaylistCtrl', function($scope, $stateParams) {
})


.controller('PlanCtrl', function($ionicPlatform , $http , $scope, $stateParams) {

    $ionicPlatform.ready(function() {

        $http.post(AJAX_URL + 'current_plan.ajax.php', {
            'user_id' : 1
        })
            .success(function (data) {
                $scope.current_plan = data.plan_name;
                console.log(data);
            });

        $http.post(AJAX_URL + 'modes.ajax.php', {
            'user_id' : 1
        })
            .success(function (data) {
                $scope.modes = data;
            });


        $scope.modeUpdate = function(modeId){

            $http.post(AJAX_URL + 'modeUpdate.ajax.php', {
                'modeId' : modeId
            })
                .success(function (data) {
                    $scope.data = data;
                    $scope.current_plan = data.modeName
                });


        }


    });

})

.controller('HomeCtrl', function($http, $scope, $stateParams) {



            $http.post(AJAX_URL + 'current_plan.ajax.php', {
                'user_id' : 1
            })
                .success(function (data) {
                    $scope.current_plan = data.plan_name;
                    console.log(data);
                });




        setInterval(function(){

            var uretim = Math.floor((Math.random() * 10000) + 7000);
            var tuketim = Math.floor((Math.random() * 7000) + 1);

            $scope.uretim = uretim;
            $scope.tuketim = tuketim;



            $scope.uretim = uretim;
            $scope.tuketim = tuketim;

            var Fark = uretim - tuketim;

            $scope.fark = Fark;

        }, 500);


})

.controller('LoginCtrl', function($scope, $state, $ionicPopup) {

    $scope.LoginData = {};

    $scope.LoginPost = function(){

        if (!$scope.LoginData.email || !$scope.LoginData.password){
            var alertPopup = $ionicPopup.alert({
                title: 'Hey!',
                template: 'Lütfen boş alan bırakmadan tekrar deneyin!'
            });
        }else  {

            if ($scope.LoginData.email == 'eftalyurtseven@gmail.com' && $scope.LoginData.password == '123456'){
                window.localStorage.setItem("USERLOGIN", true);
                $state.go('app.home');
            } else {
                var alertPopup = $ionicPopup.alert({
                    title: 'Hey!',
                    template: 'Girdiğiniz bilgileri kontrol edip tekrar deneyin!'
                });
            }

        }

    }
})

.controller('WelcomeCtrl', function($scope, $state) {



})


.controller('NotificationsCtrl', function($scope, $state) {



})


.controller('SettingsCtrl', function($scope, $state) {



})


.controller('ModesCtrl', function($ionicPlatform, $http , $scope, $state) {


    $ionicPlatform.ready(function() {

        $http.post(AJAX_URL + 'modes.ajax.php', {
            'user_id' : 1
        })
            .success(function (data) {
                $scope.modes = data;
            });

    });


})

.controller('modeAddCtrl', function($ionicPopup, $http, $ionicPlatform, $scope, $state) {

    $ionicPlatform.ready(function() {

        $http.post(AJAX_URL + 'devices.ajax.php', {
            'user_id' : 1
        })
        .success(function (data) {
            $scope.devices = data;
        });


        $scope.ModeData = {};
        $scope.modeAdd = function (){

            var name = $scope.ModeData.name;
            var energy = $scope.ModeData.energy;

            $http.post(AJAX_URL + 'modeAdd.ajax.php', {
                'name' : name,
                'energy' : energy
            })
            .success(function (data) {
               if (data.code == 301){
                   var alertPopup = $ionicPopup.alert({
                       title: 'Başarılı!',
                       template: 'İşlem başarıyla gerçekleşti!'
                   });
                   setTimeout(function(){
                       $state.go('app.modes');
                   }, 1000);
               } else if (data.code == 303){
                   var alertPopup = $ionicPopup.alert({
                       title: 'Hey!',
                       template: 'Bu isimle bir mod mevcut!'
                   });
               }else {
                   var alertPopup = $ionicPopup.alert({
                       title: 'Hata!',
                       template: 'Sistemde hata var!'
                   });
               }
            });

        }


    });

})

.controller('DevicesCtrl', function($ionicPlatform , $http , $scope, $state) {

        $ionicPlatform.ready(function() {

            $http.post(AJAX_URL + 'devices.ajax.php', {
               'user_id' : 1
            })
                .success(function (data) {
                    $scope.devices = data;
                });

        });

})


.controller('DeviceAddCtrl', function($ionicPlatform, $ionicPopup , $scope, $http , $state) {
    $ionicPlatform.ready(function() {

        $scope.deviceData = {};
        $scope.deviceAdd = function (){

            var name = $scope.deviceData.name;
            var energy = $scope.deviceData.energy;
            var time = $scope.deviceData.time;

            if (!name || !energy || !time){

            }else {
                $http.post(AJAX_URL + 'deviceAdd.ajax.php', {
                    'name': name,
                    'energy': energy,
                    'time': time
                })
                    .success(function (data) {
                        if (data.id == 1) {
                            var alertPopup = $ionicPopup.alert({
                                title: 'Hey!',
                                template: 'Cihaz başarıyla eklendi!'
                            });

                            setTimeout(function(){
                                $state.go('app.devices');
                            }, 1000);
                        }else if (data.id == 302) {
                            var alertPopup = $ionicPopup.alert({
                                title: 'Hey!',
                                template: 'Bu isimle bir cihaz kaydetmişsiniz!'
                            });
                        }else {
                            var alertPopup = $ionicPopup.alert({
                                title: 'Hey!',
                                template: 'Kayıt gerçekleşemedi!'
                            });
                        }
                    });
            }

        }

    });
});
