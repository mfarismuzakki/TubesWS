			     <main class="col-sm-9 offset-sm-3 col-md-10 offset-md-2 pt-3">
					<!-- pencarian -->
					<label>Cari Buku Berdasarkan</label>	
						<form action="<?php echo site_url('CUserCari/CariBuku'); ?>" method="post" class="form">
							<div class="form-group row">
								<div class="col-2">
									<select class="form-control" name="berdasarkan">
										<option>ID</option>
										<option>Judul Buku</option>
										<option>Penerbit</option>
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