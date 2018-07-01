				<table class="table table-hover">
					<thead>
						<tr>
							<th>No</th>
							<th>Nama Bahasa</th>
						</tr>
					</thead>
					<?php $i = $this->uri->segment(3)+1;foreach($buku as $var){?>
						<tr>
							<td><?php echo $i++; ?></td>
							<td><?php echo $var->nama_bahasa; ?></td>
						</tr>
					<?php } ?>
				</table>
				<?php echo $this->pagination->create_links(); ?>
			</div>
		</main>
	</div>
</div>	