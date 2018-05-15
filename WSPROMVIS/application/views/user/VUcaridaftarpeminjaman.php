			     <main class="col-sm-9 offset-sm-3 col-md-10 offset-md-2 pt-3">
					<!-- pencarian -->
					<label>Pinjam Buku</label><br><br>	
					<form  method="post" action="<?php echo site_url('CUsercari/CariDaftarPeminjaman'); ?>">
						<div class="form-group row">
							<div class="col-4">
								<label>Peminjam</label>
								<input type="text" name="peminjam" placeholder="peminjam" class="form-control">
							</div>
						</div>
						<div class="row">
							<div class="col-4">
								<label>Pustakawan</label><br>
								<input type="text" name="pustakawan" placeholder="pustakawan" class="form-control" readonly="" value="2" ><br>
							</div>
							<div class="offset-3 col-2">
								
								<input type="submit" name="submit" class="form-control btn btn-primary" value="Add">
							</div>
						</div>	
					</form>


					<table class="table table-hover">
						<thead>
							<tr>
								<th>No</th>
								<th>Judul Buku</th>
								<th>Pengarang</th>
								<th>Penerbit</th>
								<th>Aksi</th>
							</tr>
						</thead>
						<?php $i=1; foreach($buku as $var){ ?>
						<tr>
							<td><?php echo $i; ?></td>
							<td><?php echo $var->judul; ?></td>
							<td><?php echo $var->penulis; ?></td>
							<td><?php echo $var->penerbit; ?></td>
							<td><a href="<?php echo site_url('CUserCari/DeleteTambahBuku/').$var->id_buku; ?>" class="btn btn-danger">Hapus</a></td>
						</tr>

						<?php $i++;} ?>
					</table>