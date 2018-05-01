				<table class="table table-hover">
					<thead>
						<tr>
							<th>No</th>
							<th>Nama Bahasa</th>
						</tr>
					</thead>
					<?php $i = 1;foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->nama_bahasa; ?></td>
						</tr>
					<?php } ?>
				</table>
			</div>
		</main>
	</div>
</div>	