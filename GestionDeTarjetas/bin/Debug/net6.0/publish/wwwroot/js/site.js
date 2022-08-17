// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.getElementById('alertSuccess').hidden = true;




function ocultatePlease() {
	document.getElementById('alertExcel').hidden = true;
}

(function ($) {

	"use strict";

	var fullHeight = function () {

		$('.js-fullheight').css('height', $(window).height());
		$(window).resize(function () {
			$('.js-fullheight').css('height', $(window).height());
		});

	};
	fullHeight();

	$('#sidebarCollapse').on('click', function () {
		$('#sidebar').toggleClass('active');
	});

})(jQuery);


function show() {
	document.getElementById('alertSuccess').hidden = false;
}

function showExcel() {
	document.getElementById('alertExcel').hidden = false;
}



function cerrar() {
	document.getElementById('alertSuccess').hidden = true;
}

function cerrarExcel() {
	document.getElementById('alertExcel').hidden = true;
}

$(function () {
	$('select').selectpicker();
});


