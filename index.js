// Import the express library
const express = require('express');
// Create an Express application
const app = express();
// Define the port, using the one provided by Render or defaulting to 3000
const port = process.env.PORT || 3000;

// Define a route for the root URL
app.get('/', (req, res) => {
  // Send a JSON response
  res.json({ message: "¡Hola, mundo desde Render!" });
});

// Start the server and listen on the defined port
app.listen(port, () => {
  console.log(`Web service listening on port ${port}`);
});