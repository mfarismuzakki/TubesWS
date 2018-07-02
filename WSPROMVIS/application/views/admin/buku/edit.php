<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/EditBuku/'.$buku['id_buku']);?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Judul</label>
        <div class="col-lg-5">
            <input type="text" name="judul" class="form-control" value="<?php echo $buku['judul'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Cetakan</label>
        <div class="col-lg-5">
            <input type="text" name="cetakan" class="form-control" value="<?php echo $buku['cetakan'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tanggal Terbit</label>
        <div class="col-lg-5">
            <input type="text" name="tanggalterbit" id="tanggal" class="form-control" value="<?php echo $buku['tanggalterbit'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Penulis</label>
        <div class="col-lg-5">
            <input type="text" name="penulis" class="form-control" value="<?php echo $buku['penulis'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Penerbit</label>
        <div class="col-lg-5">
            <input type="text" name="penerbit" class="form-control" value="<?php echo $buku['penerbit'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Kategori</label>
        <div class="col-lg-5">
            <input type="text" name="kategori" class="form-control" value="<?php echo $buku['kategori'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Bahasa</label>
        <div class="col-lg-5">
            <input type="text" name="bahasa" class="form-control" value="<?php echo $buku['bahasa'];?>">
        </div>
    </div>

    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Update</button>
        <a href="<?php echo site_url('CAdmin/Buku');?>" class="btn btn-default">Kembali</a>
    </div>
</form>
