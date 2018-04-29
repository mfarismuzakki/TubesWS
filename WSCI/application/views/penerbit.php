
	<div class="container">
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
	</div>

</body>
</html>