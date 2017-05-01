// Ionic Starter App
var AJAX_URL = "http://www.kanlazimapp.com/smartbright/php/";
// angular.module is a global place for creating, registering and retrieving Angular modules
// 'starter' is the name of this angular module example (also set in a <body> attribute in index.html)
// the 2nd parameter is an array of 'requires'
// 'starter.controllers' is found in controllers.js
angular.module('starter', ['ionic', 'starter.controllers'])

.run(function($ionicPlatform) {
  $ionicPlatform.ready(function() {
    // Hide the accessory bar by default (remove this to show the accessory bar above the keyboard
    // for form inputs)
    if (window.cordova && window.cordova.plugins.Keyboard) {
      cordova.plugins.Keyboard.hideKeyboardAccessoryBar(true);
      cordova.plugins.Keyboard.disableScroll(true);

    }
    if (window.StatusBar) {
      // org.apache.cordova.statusbar required
      StatusBar.styleDefault();
    }
  });
})

.config(function($stateProvider, $urlRouterProvider) {
  $stateProvider

    .state('app', {
    url: '/app',
    abstract: true,
    templateUrl: 'templates/menu.html',
    controller: 'AppCtrl'
  })

  .state('app.search', {
    url: '/search',
    views: {
      'menuContent': {
        templateUrl: 'templates/search.html'
      }
    }
  })

  .state('app.browse', {
      url: '/browse',
      views: {
        'menuContent': {
          templateUrl: 'templates/browse.html'
        }
      }
    })

  .state('app.Notifications', {
    url: '/Notifications',
    views: {
      'menuContent': {
        templateUrl: 'templates/Notifications.html',
        controller: 'NotificationsCtrl'
      }
    }
  })

  .state('app.home', {
      url: '/home',
      views: {
          'menuContent': {
              templateUrl: 'templates/home.html',
              controller: 'HomeCtrl'
          }
      }
  })



  .state('app.devices', {
      url: '/devices',
      views: {
          'menuContent': {
              templateUrl: 'templates/devices.html',
              controller: 'DevicesCtrl'
          }
      }
  })

  .state('app.deviceAdd', {
      url: '/deviceAdd',
      views: {
          'menuContent': {
              templateUrl: 'templates/deviceAdd.html',
              controller: 'DeviceAddCtrl'
          }
      }
  })

  .state('app.settings', {
      url: '/settings',
      views: {
          'menuContent': {
              templateUrl: 'templates/settings.html',
              controller: 'SettingsCtrl'
          }
      }
  })

  .state('app.welcome', {
      url: '/welcome',
      views: {
          'menuContent': {
              templateUrl: 'templates/welcome.html',
              controller: 'WelcomeCtrl'
          }
      }
  })

  .state('app.modes', {
      url: '/modes',
      views: {
          'menuContent': {
              templateUrl: 'templates/modes.html',
              controller: 'ModesCtrl'
          }
      }
  })


  .state('app.modeAdd', {
      url: '/modeAdd',
      views: {
          'menuContent': {
              templateUrl: 'templates/modeAdd.html',
              controller: 'modeAddCtrl'
          }
      }
  })

  .state('app.login', {
      url: '/login',
      views: {
          'menuContent': {
              templateUrl: 'templates/login.html',
              controller: 'LoginCtrl'
          }
      }
  })


  .state('app.plan', {
      url: '/plan',
      views: {
          'menuContent': {
              templateUrl: 'templates/plan.html',
              controller: 'PlanCtrl'
          }
      }
  })

  .state('app.single', {
    url: '/playlists/:playlistId',
    views: {
      'menuContent': {
        templateUrl: 'templates/playlist.html',
        controller: 'PlaylistCtrl'
      }
    }
  });
  // if none of the above states are matched, use this as the fallbac
    if (window.localStorage.USERLOGIN == true){
        $urlRouterProvider.otherwise('/app/home');
    }else {
        $urlRouterProvider.otherwise('/app/welcome');
    }


});
