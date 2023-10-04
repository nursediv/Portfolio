let interval = 1000;
let score= 0;
let monsterHopping;
let gameArea;
let monster;

document.addEventListener('DOMContentLoaded', function(){
gameArea = document.querySelector(".container");
monster = document.querySelector(".monster-container");

if (monster)
	{
		monster.addEventListener("click", monsterClick);
	}

startMonsterMoving(); //start the monster moving 

const resetSpeedButton = document.querySelector("#reset-speed-btn");
if(resetSpeedButton){
	resetSpeedButton.addEventListener("click", function(){
	resetSpeed();
});
}
//reset speed and score functions for buttons 
const resetScoreButton = document.querySelector("#reset-score-btn");
if(resetScoreButton)
{
	resetScoreButton.addEventListener("click", function(){
	resetScore();
		});
	}
});
function monsterClick()
{
	//increase score everytime player clicks the monster 
	score++;
	let scoreElement = document.getElementById("score");
	
	if(scoreElement)
	{
		scoreElement.innerText = score;
	}

	//decrease the time interval 
	interval -= 50;
	let intervalElement = document.getElementById("Interval");

	if (intervalElement)
	{
	intervalElement.innerText = interval +"ms";
	}

	//do not stop the monster hopping 
	startMonsterMoving();

}

function stopMonsterMoving()
{
	clearInterval(monsterHopping);
}
function startMonsterMoving(){
	clearInterval(monsterHopping);
	monsterHopping = setInterval(moveMonster, interval);
}
function moveMonster() {

	if (!gameArea || !monster) return;

	// dimensions of game area (full document)
	let gameAreaWidth = document.documentElement.clientWidth;
	let gameAreaHeight = document.documentElement.clientHeight;
	
	//monster element
	let monsterWidth= monster.offsetWidth;
	let monsterHeight = monster.offsetHeight;

	// calculate the random position for the monster within the entire page
	let randomLeft = Math.random() * (gameAreaWidth - monster.offsetWidth);
	let randomTop = Math.random() * (gameAreaHeight - monster.offsetHeight);
	
	// Move monster to the new random position
	monster.style.left = randomLeft + "px";
	monster.style.top = randomTop + "px";
  }
  
function resetSpeed()
{
	interval = 1000;
	let intervalElement= document.getElementById("interval");
	if (intervalElement)
	{
		intervalElement.innerText = interval +"ms";
	}
	//start movement with new interval 
	startMonsterMoving();
}
function resetScore()
{
	score= 0;
	let scoreElement=document.getElementById("score");
	if (scoreElement)
	{
		scoreElement.innerText = score;
	}
}