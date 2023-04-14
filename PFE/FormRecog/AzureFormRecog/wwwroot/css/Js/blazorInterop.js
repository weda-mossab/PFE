window.has = window.has || {};
window.has.blazorInterop = {
    initializeSignalR: function() {
        var connection = new signalR.HubConnectionBuilder()
            .withUrl("/hub")
            .build();
        connection.start();
    }
};