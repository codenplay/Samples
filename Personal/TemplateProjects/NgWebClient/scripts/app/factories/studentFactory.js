app.factory('studentFactory', function ($resource,setting) {
    return $resource(setting.mapUrl, {}, { 'query': { isArray: false } });
});