
	<div class="container">
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

</body>
</html>