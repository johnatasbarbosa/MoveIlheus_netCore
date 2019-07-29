// This example requires the Drawing library. Include the libraries=drawing
// parameter when you first load the API. For example:
// <script src="https://maps.googleapis.com/maps/api/js?key=YOUR_API_KEY&libraries=drawing">

var coordenadas = [];
var map;
      
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: {lat: -15.677411962720948, lng: -38.949223898933894},
        zoom: 15,
        //zoomControl: boolean,
        //mapTypeControl: boolean,
        //scaleControl: false,
        streetViewControl: false,
        //rotateControl: boolean,
        fullscreenControl: false
    });
}
    