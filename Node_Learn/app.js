var http = require('http');

var hostname = '127.0.0.1';
var port = 3000;
console.log("HTTP server is listening at port 3000.");
var server = http.createServer((req, res) => {
    res.writeHead(200, {'Content-type':'text/html'});
    res.end('<h1>Hello NodeJS</h1>');
});

server.listen(port, hostname, () => {
  console.log(`服务器运行在 http://${hostname}:${port}/`);
})