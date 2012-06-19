﻿/**
 * Dashboard area router implementation.
 *
 * @constructor
 * @extends {CollarRouter}
 */
var DashboardRouter = CollarRouter.extend({
    routes: {
        'dashboard': 'index',
        '*path': 'index'
    },

    /**
     * Initialization.
     * @this {DashboardRouter}
     * @param {App} app The root application object.
     * @param {Object} options Additional initialization options.
     */
    initialize: function(app, options) {
        CollarRouter.prototype.initialize.call(this, app, options);
        this.options = _.extend({}, options);
    },

    /**
     * Handles the root #dashboard route.
     * @this {DashboardRouter}
     */
    index: function() {

    }
});