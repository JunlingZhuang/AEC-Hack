// read canvas elements
const canvas = document.getElementById('sketchpad');
const ctx = canvas.getContext('2d');

let isDrawing = false;

// start drawing
canvas.addEventListener('mousedown', e => {
    isDrawing = true;
    ctx.beginPath(); 
    ctx.moveTo(e.offsetX, e.offsetY);
});

// move to draw
canvas.addEventListener('mousemove', e => {
    if (isDrawing === true) {
        ctx.lineTo(e.offsetX, e.offsetY);
        ctx.stroke();
    }
});

// release to end
canvas.addEventListener('mouseup', e => {
    if (isDrawing === true) {
        ctx.lineTo(e.offsetX, e.offsetY);
        ctx.stroke();
        ctx.closePath();
        isDrawing = false;
    }
});

// submit button event
document.getElementById('submitBtn').addEventListener('click', function() {
    const dataURL = canvas.toDataURL('image/png');
    console.log(dataURL); 
});