
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
	</div>

</body>
</html>