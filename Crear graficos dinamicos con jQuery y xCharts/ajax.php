<?php

header('Content-Type: application/json');

// Set up the ORM library
require_once('setup.php');

if (isset($_GET['start']) AND isset($_GET['end'])) {
	
	$start = $_GET['start'];
	$end = $_GET['end'];
	$data = array();

	// Select the results with Idiorm
	$results = ORM::for_table('operacion')
			->where_gte('Ope_Fecha', $start)
			->where_lte('Ope_Fecha', $end)
			->order_by_desc('Ope_Fecha')
			->find_array();


	// Build a new array with the data
	foreach ($results as $key => $value) {
		$data[$key]['label'] = $value['Ope_Fecha'];
		$data[$key]['value'] = $value['Ope_Venta'];
	}

	echo json_encode($data);
}
