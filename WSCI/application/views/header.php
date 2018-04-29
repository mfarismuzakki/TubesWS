<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous">

	<title>Debug</title>
</head>
<body>
	<div class="container" style="margin-top: 20px">
		
		<div class="btn-group" role="group">
			
				<a href="<?php echo site_url(); ?>" class="btn btn-primary <?php if ($menu === "Home") echo "disabled"; ?>" <?php if ($menu === "home") echo "disabled"; ?>" role="button">Home</a>

				<a href="<?php echo site_url('Debug/Bahasa'); ?>" class="btn btn-primary <?php if ($menu === "Bahasa") echo "disabled"; ?>"" role="button">Bahasa</a>
			
				<a href="<?php echo site_url('Debug/Deskripsi'); ?>" class="btn btn-primary <?php if ($menu === "Deskripsi") echo "disabled"; ?>"" role="button">Deskripsi</a>

				<a href="<?php echo site_url('Debug/JudulBuku'); ?>" class="btn btn-primary <?php if ($menu === "JudulBuku") echo "disabled"; ?>"" role="button">Judul Buku</a>

			
				<a href="<?php echo site_url('Debug/Kategori'); ?>" class="btn btn-primary <?php if ($menu === "Kategori") echo "disabled"; ?>"" role="button">Kategori</a>

			
				<a href="<?php echo site_url('Debug/Penerbit'); ?>" class="btn btn-primary <?php if ($menu === "Penerbit") echo "disabled"; ?>"" role="button">Penerbit</a>

			
				<a href="<?php echo site_url('Debug/Penulis'); ?>" class="btn btn-primary <?php if ($menu === "Penulis") echo "disabled"; ?>"" role="button">Penulis</a>
		</div>
		<br><br>