// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.addEventListener('keydown', async e => {
    console.log(e.key);
    if (e.key == 'q') {

        const res = await fetch('/Rest');
        const data = await res.json();

        console.log(data);

    }
})