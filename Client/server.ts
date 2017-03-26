import * as e from 'express'

let server = e();
const port = process.env.port || 1337;

server.use('/', e.static(__dirname.concat('/Views')));

server.listen(1337, () => {
    console.log('listenting on', port);
});