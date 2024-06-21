const liveServer = require("live-server");
const params = {
    port: 8085,
    host: "0.0.0.0",
    file: "index.html"
};

liveServer.start(params);