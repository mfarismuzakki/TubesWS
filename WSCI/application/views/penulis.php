<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">

	<title>Debug</title>
</head>
<body>

	<div class="row">
		<div class="col-md-2">
			<a href="<?php site_url('') ?>"></a>
		</div>
	</div>




	<div class="container">
		<h1 align="center">Penulis</h1>
		<table class="table table-hover">
			<thead>
				<th>ID</th>
				<th>Nama</th>
				<th>Tempat Lahir</th>
				<th>Tanggal Lahir</th>
				<th>Domisili</th>
			</thead>
			<?php foreach($penulis as $var){ ?>
			<tr>
				<td><?php echo $var['id_penulis']; ?></td>
				<td><?php echo $var['nama_penulis']; ?></td>
				<td><?php echo $var['tempat_lahir']; ?></td>
				<td><?php echo $var['tanggal_lahir']; ?></td>
				<td><?php echo $var['domisili']; ?></td>
			</tr>
			<?php } ?>
		</table>
	</div>



</body>
</html>