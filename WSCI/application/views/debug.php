
		<div class="container">
			<h2 align="center">Bahasa</h2>
			<table class="table table-hover">
				<thead>
					<th>ID</th>
					<th>Nama Bahasa</th>
				</thead>
				<?php foreach($bahasa as $var){ ?>
				<tr>
					<td><?php echo $var['id_bahasa']; ?></td>
					<td><?php echo $var['nama_bahasa']; ?></td>
				</tr>
				<?php } ?>
			</table>

			<h2 align="center">Deskripsi</h2>
			<table class="table table-hover">
				<thead>
					<th>ID</th>
					<th>Isi Deskripsi</th>
					<th>ID Buku</th>
				</thead>
				<?php foreach($deskripsi as $var){ ?>
				<tr>
					<td><?php echo $var['id_deskripsi']; ?></td>
					<td><?php echo $var['isi']; ?></td>
					<td><?php echo $var['id_buku']; ?></td>
				</tr>
				<?php } ?>
			</table>

			<h2 align="center">Kategori</h2>
			<table class="table table-hover">
				<thead>
					<th>ID</th>
					<th>Nama Kategori</th>
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
					<th>Nama Penerbit</th>
					<th>Lokasi Percetakan</th>
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

			<h2 align="center">Penulis</h2>
			<table class="table table-hover">
				<thead>
					<th>ID</th>
					<th>Nama Penulis</th>
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
	</div>
</body>
</html>