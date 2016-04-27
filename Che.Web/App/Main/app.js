(function () {
    'use strict';

    var app = angular.module('app', [
        'ngAnimate',
        'ngSanitize',

        'ui.router',
        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    //Configuration for Angular UI routing.
    app.config([
        '$stateProvider', '$urlRouterProvider',
        function ($stateProvider, $urlRouterProvider) {
            console.log("$stateProvider---:");
            console.log($stateProvider);
            console.log($stateProvider.state);
            console.log("$urlRouterProvider---:" );
            console.log($urlRouterProvider);

            //$urlRouterProvider.otherwise('/');

            //if (abp.auth.hasPermission('Pages.Tenants')) {
            //    $stateProvider
            //        .state('tenants', {
            //            url: '/tenants',
            //            templateUrl: '/App/Main/views/tenants/index.cshtml',
            //            menu: 'Tenants' //Matches to name of 'Tenants' menu in CheNavigationProvider
            //        });
            //    $urlRouterProvider.otherwise('/tenants');
            //}

            //$stateProvider
            //    .state('home', {
            //        url: '/',
            //        templateUrl: '/App/Main/views/home/home.cshtml',
            //        menu: 'Home' //Matches to name of 'Home' menu in CheNavigationProvider
            //    })
            //    .state('about', {
            //        url: '/about',
            //        templateUrl: '/App/Main/views/about/about.cshtml',
            //        menu: 'About' //Matches to name of 'About' menu in CheNavigationProvider
            //    })
            //    .state('lhl', {
            //        url: '/lhl',
            //        templateUrl: '/App/Main/views/lhl/lhl.cshtml',
            //        menu:'lhl'
            //    });

            $urlRouterProvider
                  .otherwise('/app/Main/Views/lhl.cshtml');
            $stateProvider
                .state('app', {
                    abstract: true,
                    url: '/app',
                    templateUrl: '/app/Main/Views/lhl.cshtml'
                })
                .state('app.dashboard', {
                    url: '/dashboard',
                    templateUrl: '/app/Main/Views/lhl.cshtml',
                    ncyBreadcrumb: {
                        label: 'Dashboard',
                        description: ''
                    }
                });

        }
    ]);
})();