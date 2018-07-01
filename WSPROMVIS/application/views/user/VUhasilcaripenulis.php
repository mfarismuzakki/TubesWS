				<table class="table table-hover" id="demo">
					<thead>
						<tr>
							<th>No</th>
							<th>Nama Penulis</th>
							<th>Tempat Lahir</th>
							<th>Tanggal Lahir</th>
							<th>Domisili</th>
						</tr>
					</thead>
					<?php $i = $this->uri->segment('3')+1;foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->nama_penulis; ?></td>
							<td><?php echo $var->tempat_lahir; ?></td>
							<td><?php echo $var->tanggal_lahir; ?></td>
							<td><?php echo $var->domisili; ?></td>
						</tr>
					<?php } ?>
				</table>
				<?php echo $this->pagination->create_links(); ?>
			</div>
		</main>
	</div>
</div>	
