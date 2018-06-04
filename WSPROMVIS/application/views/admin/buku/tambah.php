<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/TambahBuku');?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Judul</label>
        <div class="col-lg-5">
            <input type="text" name="judul" class="form-control">
        </div>
    </div>
    
    <div class="form-group">
        <label class="col-lg-2 control-label">Cetakan</label>
        <div class="col-lg-5">
            <input type="text" name="cetakan" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tanggal Terbit</label>
        <div class="col-lg-5">
            <input type="text" name="tanggalterbit" id="tanggal" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Penulis</label>
        <div class="col-lg-5">
            <input type="text" name="penulis" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Penerbit</label>
        <div class="col-lg-5">
            <input type="text" name="penerbit" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Kategori</label>
        <div class="col-lg-5">
            <input type="text" name="kategori" class="form-control">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Bahasa</label>
        <div class="col-lg-5">
            <input type="text" name="bahasa" class="form-control">
        </div>
    </div>
    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Simpan</button>
        <a href="<?php echo site_url('CAdmin/Buku');?>" class="btn btn-default">Kembali</a>
    </div>
</form>