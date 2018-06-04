<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/TambahAnggota');?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Nama</label>
        <div class="col-lg-5">
            <input type="text" name="nama_anggota" class="form-control">
        </div>
    </div>
    
    <div class="form-group">
        <label class="col-lg-2 control-label">Jenis Kelamin</label>
        <div class="col-lg-5">
            <select name="jenis_kelamin" class="form-control">
                <option></option>
                <option value="L">L</option>
                <option value="P">P</option>
            </select>
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tempat Lahir</label>
        <div class="col-lg-5">
            <input type="text" name="tempat_lahir" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tanggal Lahir</label>
        <div class="col-lg-5">
            <input type="text" name="tanggal_lahir" id="tanggal" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">No Telepon</label>
        <div class="col-lg-5">
            <input type="text" name="notelepon" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Alamat</label>
        <div class="col-lg-5">
            <input type="textarea" name="alamat" class="form-control">
        </div>
    </div>
    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Simpan</button>
        <a href="<?php echo site_url('CAdmin/Anggota');?>" class="btn btn-default">Kembali</a>
    </div>
</form>