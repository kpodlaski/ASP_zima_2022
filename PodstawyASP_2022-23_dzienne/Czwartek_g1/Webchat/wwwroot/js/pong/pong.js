/* Author: Krzysztof Podlaski, University of Lodz */

function moveUp() {
	return;
}



class Ball {

	constructor(x, y, width, height, img) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
		this.img = img;
	}

	show() {
		this.img.style.left = this.x + "px";
		this.img.style.top = this.y + "px";
	}
}

class Palette {
	constructor(x, y, width, height, img) {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
		this.img = img;
		
		document.addEventListener('keyup', (e) => {
			if (e.code === "ArrowUp") {
				fetch('api/PongGame?id=0&direction=-1', {
					method: 'PUT',
				})
					.then((raw_data) => {
						//console.log(raw_data);
						return "";
					})
			}
			else if (e.code === "ArrowDown") {
				fetch('api/PongGame?id=0&direction=1', {
					method: 'PUT',
				})
					.then((raw_data) => {
						//console.log(raw_data);
						return "";
					})
			}
		});
	}

	show() {
		this.img.style.left = this.x + "px";
		this.img.style.top = this.y + "px";
		console.log(this.img.style.left);
	}
}

var screen = {'ball': "", 'palettes':[]}

function updateScreen() {
	screen['ball'].show();
	screen['palettes'][0].show();
}


function updateFromServer() {
	fetch('api/ponggame', {
		method: 'GET',
	})
		.then((raw_data) => {
			return raw_data.json();
		}).then((data) => {
			screen['ball'].x = data.ball.x;
			screen['ball'].y = data.ball.y;
			screen['palettes'][0].x = data.palettes[0].x;
			screen['palettes'][0].y = data.palettes[0].y;
	});
}

function animate() {
	updateFromServer();
	updateScreen();
	setTimeout(animate, 50);
}

function init() {
	var canvas = document.getElementById("pong_container");
	var scale = 10;
	var ball_img = document.getElementById("ball_img");
	screen['ball'] = new Ball(30, 90, 300, 300, ball_img);
	var pallette_img = document.getElementById("pallete0");
	console.log(pallette_img)
	screen['palettes'].push(new Palette(300, 30, 300, 300, pallette_img));
	fetch('api/ponggame', {
		method: 'POST',
	})
		.then((raw_data) => {
			return raw_data.json();
		}).then((data) => {
			console.log(data);
			animate();
		});
}

document.getElementById("pong_container").style.backgroundColor = "green purple";
document.addEventListener('load', init(), false);
