
	<div class="container">
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
	</div>

</body>
</html>