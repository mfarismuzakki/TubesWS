
	<div class="container">
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
	</div>

</body>
</html>