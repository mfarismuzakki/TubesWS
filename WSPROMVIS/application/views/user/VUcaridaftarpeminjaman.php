			     <main class="col-sm-9 offset-sm-3 col-md-10 offset-md-2 pt-3">
					<!-- pencarian -->
					<label>Pinjam Buku</label><br><br>	
					<form  method="post" action="<?php echo site_url('UserHome/CariDaftarPeminjaman'); ?>">
						<div class="form-group row">
							<div class="col-4">
								<label>Peminjam</label>
								<input type="text" name="peminjam" placeholder="peminjam" class="form-control">
							</div>
						</div>
						<div class="row">
							<div class="col-4">
								<label>Pustakawan</label><br>
								<input type="text" name="pustakawan" placeholder="pustakawan" class="form-control"><br>
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
							</tr>
						</thead>

					</table>