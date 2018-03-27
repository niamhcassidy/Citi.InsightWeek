<?php
$servername = "localhost3306";
$username = "root";
$password = "c0nygre";

// Create connection
	$conn = new mysqli($servername, $username, $password)or die ('No
	connection');
	mysqli_select_db($conn, 'contactsdb' ) or die (' database will not open');

    $query = "SELECT * FROM MarketData WHERE Ticker ='AAAP";
	
	$result = mssql_query( $query );
	
	for ($i = 0; $i < mssql_num_rows( $result ); ++$i)
     {
         $line = mssql_fetch_row($result);
         print( "$line[0] - $line[1]\n");
     }
?>
	