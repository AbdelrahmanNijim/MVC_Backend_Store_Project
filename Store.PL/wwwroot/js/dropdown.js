document.getElementById('userDropdown').addEventListener('click', function (event) {
    event.preventDefault();
    var dropdown = new bootstrap.Dropdown(this);
    dropdown.toggle();
});

