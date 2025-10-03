// Import the express library
const express = require('express');
// Create an Express application
const app = express();
// Define the port, using the one provided by Render or defaulting to 3000
const port = process.env.PORT || 3000;

// Define a route for the root URL
app.get('/', (req, res) => {
	// Se obtiene el parámetro "Nombre" de la consulta (query) en la URL.
	// Si no se proporciona, se usa 'mundo' como valor por defecto.
	const nombre = req.query.Nombre || 'mundo';
	
	// Se construye el mensaje de saludo concatenando el nombre recibido.
	const saludo = `¡Hola mundo, ${nombre}!`;

	// Se envía una respuesta JSON con el mensaje dinámico.
	res.json({ message: saludo });
});

// Start the server and listen on the defined port
app.listen(port, () => {
	console.log(`Web service listening on port ${port}`);
});