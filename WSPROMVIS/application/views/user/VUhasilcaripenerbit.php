				<table class="table table-hover">
					<thead>
						<tr>
							<th>No</th>
							<th>Nama Penerbit</th>
							<th>Lokasi Percetakan</th>
							<th>No Kontak</th>
						</tr>
					</thead>
					<?php $i=1; foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->nama_penerbit; ?></td>
							<td><?php echo $var->lokasipercetakan; ?></td>
							<td><?php echo $var->notelepon	; ?></td>
						</tr>
					<?php } ?>
				</table>
			</div>
		</main>
	</div>
</div>
