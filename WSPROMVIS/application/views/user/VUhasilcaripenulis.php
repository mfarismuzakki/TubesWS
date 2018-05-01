				<table class="table table-hover">
					<thead>
						<tr>
							<th>No</th>
							<th>Nama Penulis</th>
							<th>Tempat Lahir</th>
							<th>Tanggal Lahir</th>
							<th>Domisili</th>
						</tr>
					</thead>
					<?php $i = 1;foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->nama_penulis; ?></td>
							<td><?php echo $var->tempat_lahir; ?></td>
							<td><?php echo $var->tanggal_lahir; ?></td>
							<td><?php echo $var->domisili; ?></td>
						</tr>
					<?php } ?>
				</table>
			</div>
		</main>
	</div>
</div>	