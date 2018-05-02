				<table class="table table-hover">
					<thead>
						<tr>
							<th>No</th>
							<th>Nama kategori</th>
						</tr>
					</thead>
					<?php $i = 1;foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->nama_kategori; ?></td>
						</tr>
					<?php } ?>
				</table>
			</div>
		</main>
	</div>
</div>	