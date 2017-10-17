var http = require('http');

var hostname = '127.0.0.1';
var port = 8081;
console.log("HTTP server is listening at port 8081.");
var server = http.createServer((req, res) => {
    res.writeHead(200, {'Content-type':'text/html'});
    res.end('<h1>Hello Nodejs</h1>');
});

server.listen(port, hostname, () => {
  console.log(`服务器运行在 http://${hostname}:${port}/`);
})