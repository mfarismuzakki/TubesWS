
	<div class="container">
		<h2 align="center">Judul Buku</h2>
			<table class="table table-hover">
				<thead>
					<th>ID</th>
					<th>Judul Buku</th>
					<th>Cetakan ke</th>
					<th>Tahun Terbit</th>
					<th>ID Penulis</th>
					<th>ID Penerbit</th>
					<th>ID Bahasa</th>
					<th>ID Kategori</th>
				</thead>
				<?php foreach($deskripsi as $var){ ?>
				<tr>
					<td><?php echo $var['id_buku']; ?></td>
					<td><?php echo $var['judul_buku']; ?></td>
					<td><?php echo $var['cetakan']; ?></td>
					<td><?php echo $var['tanggalterbit']; ?></td>
					<td><?php echo $var['id_penulis']; ?></td>
					<td><?php echo $var['id_penerbit']; ?></td>
					<td><?php echo $var['id_bahasa']; ?></td>
					<td><?php echo $var['id_kategori']; ?></td>
				</tr>
				<?php } ?>
			</table>
	</div>

</body>
</html>