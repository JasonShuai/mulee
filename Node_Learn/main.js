/*
 * 	异步实现不阻塞线程
	var fs = require("fs");
	var data = fs.readFileSync('input.txt');
	console.log(data.toString());
	console.log("程序运行完成!");
*/

/*
 * 事件驱动程序

	//  引入events
	var events = require('events');
	
	//	创建 eventEmitter 对象
	var eventEmitter = new events.EventEmitter();
	
	//  创建事件处理程序
	var connectHandler = function connected(){
		console.log('连接成功');
		
		//  触发  data_received
		eventEmitter.emit('data_received');
	}
	
	//  绑定connection事件处理程序
	eventEmitter.on('connection',connectHandler);
	
	//  使用匿名函数绑定  data_received 事件
	eventEmitter.on('data_received',function(){
		console.log('数据连接成功.');
	})
	
	//  触发connection 事件
	eventEmitter.emit('connection');
	
	console.log("程序执行完毕");
 */

/*
 * 异步读取文件(报错时执行的方法)

	var fs = require('fs');
	fs.readFile('input.txt',function(err,data){
		if(err){
			console.log(err.stack);
			return;
		}
		
		console.log(data.toString());
	});
	console.log('程序执行完毕');
 */

/*
 * eventEmitter
 */
	// 引入events模块
	var events = require('events');
	
	// 创建eventEmitter 对象
	var eventEmitter = new events.EventEmitter();

	// event.js 文件
	var EventEmitter = require('events').EventEmitter;
	
	var event = new EventEmitter;
	
	event.on('someValue',function(){
			console.log('some_event 事件触发');
	});
	setTimeout(function(){
		event.emit('some_event');
	},1000);
