				<table class="table table-hover">
					<thead>
						<tr>
							<th>No</th>
							<th>Judul Buku</th>
							<th>Cetakan</th>
							<th>Tanggal Terbit</th>
							<th>Penulis</th>
							<th>Penerbit</th>
							<th>Kategori</th>
							<th>Bahasa</th>
							<th>Stok</th>
							<th>aksi</th>
						</tr>
					</thead>
					<?php $i = 1;foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->judul; ?></td>
							<td><?php echo $var->cetakan; ?></td>
							<td><?php echo $var->tanggalterbit; ?></td>
							<td><?php echo $var->penulis; ?></td>
							<td><?php echo $var->penerbit; ?></td>
							<td><?php echo $var->kategori; ?></td>
							<td><?php echo $var->bahasa; ?></td>
							<td></td>
							<td><a href="<?php echo site_url('CUserCari/TambahBuku/'.$var->id_buku); ?>" class="btn btn-primary">Pinjam</a></td>
						</tr>
					<?php } ?>
				</table>
			</div>
		</main>
	</div>
</div>	