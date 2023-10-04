"use strict";
/*    JavaScript 7th Edition
      Chapter 12
      Project 12-04

      Project to create an interactive slideshow
      Author: 
      Date:   

      Filename: project12-04.js
*/
$(function(){
      //initialize elements with var 
      //add slide image elements 
      //add index for elements to iterate through images with jquery effects 
      var slideIndex = 0; 
      var slideCount = $slides.length;

      var $slides= $('.slideImages'); 
      var $caption =$('#caption');

      //buttons
      var $leftButton = $('#leftbutton');
      var $rightButton= $('#rightbutton');

      //left and right functions 

      $leftButton.click(function(){
            changeSlide(-1);
      });

      $rightButton.click(function(){
            changeSlide(+1);
      });

      //update captions with each photo displayed 
      function updateCaption(index){
            var $currentSlide = $slides.eq(index);
            $caption.text($currentSlide.attr('alt'));

            //alt of JPEG called from the html JPEG identifiers 
      
      }

      //change slides 
      function changeSlide(direction){
            $slides.eq(slideIndex).hide();
            slideIndex += direction;

            if(slideIndex <0){
                  slideIndex = slideCount-1;
            }
            else if (slideIndex >= slideCount) {
                  slideIndex = 0;
            }

            updateCaption(slideIndex);
            $slides.eq(slideIndex).show(); 
            
                  for(let i=0; i< $slides.length; i++){
                        const $currentSlide = $slides.eq(i);
                        const leftValue = i ===slideIndex ? 0 : 400 * (i-slideIndex);
                        $currentSlide.css('right', rightValue +'px');
            }
      }
});

