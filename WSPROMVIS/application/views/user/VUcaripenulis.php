			     <main class="col-sm-9 offset-sm-3 col-md-10 offset-md-2 pt-3">
					<!-- pencarian -->
					<label>Cari Penulis Berdasarkan</label>
						<form action="<?php echo site_url('CUserCari/Caripenulis'); ?>" method="post" class="form">
							<div class="form-group row">
								<div class="col-2">
									<select class="form-control" name="berdasarkan">
										<!-- <option>ID</option> -->
										<option>Nama Penulis</option>
										<option>Tempat Lahir</option>
										<option>Tanggal Lahir</option>
										<option>Domisili</option>
									</select>
								</div>
								<div class="col-5">
									<input type="text" name="cari" class="form-control" placeholder="Cari...">
								</div>
								<div class="col-2">
									<input type="submit" name="submit" class="btn btn-primary">
								</div>
							</div>
						</form>
