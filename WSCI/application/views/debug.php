<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">

	<title>Debug</title>
</head>
<body>

	<div class="row">
		<div class="col-md-2">
			<a href="<?php echo site_url('Penulis'); ?>" class="btn btn-default">Penulis</a>
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

		<h2 align="center">Bahasa</h2>
		<table class="table table-hover">
			<thead>
				<th>ID</th>
				<th>Nama</th>
			</thead>
			<?php foreach($bahasa as $var){ ?>
			<tr>
				<td><?php echo $var['id_bahasa']; ?></td>
				<td><?php echo $var['nama_bahasa']; ?></td>
			</tr>
			<?php } ?>
		</table>

		<h2 align="center">Kategori</h2>
		<table class="table table-hover">
			<thead>
				<th>ID</th>
				<th>Nama</th>
			</thead>
			<?php foreach($kategori as $var){ ?>
			<tr>
				<td><?php echo $var['id_kategori']; ?></td>
				<td><?php echo $var['nama_kategori']; ?></td>
			</tr>
			<?php } ?>
		</table>

		<h2 align="center">Penerbit</h2>
		<table class="table table-hover">
			<thead>
				<th>ID</th>
				<th>Nama</th>
				<th>Lokasi</th>
				<th>No Telepon</th>
			</thead>
			<?php foreach($penerbit as $var){ ?>
			<tr>
				<td><?php echo $var['id_penerbit']; ?></td>
				<td><?php echo $var['nama_penerbit']; ?></td>
				<td><?php echo $var['lokasi_percetakan']; ?></td>
				<td><?php echo $var['notelepon']; ?></td>
			</tr>
			<?php } ?>
		</table>





	</div>



</body>
</html>