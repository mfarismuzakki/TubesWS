<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/EditPenulis/'.$penulis['id_penulis']);?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Nama</label>
        <div class="col-lg-5">
            <input type="text" name="nama_penulis" class="form-control" value="<?php echo $penulis['nama_penulis'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tempat Lahir</label>
        <div class="col-lg-5">
            <input type="text" name="tempat_lahir" class="form-control" value="<?php echo $penulis['tempat_lahir'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Tanggal Lahir</label>
        <div class="col-lg-5">
            <input type="text" name="tanggal_lahir" id="tanggal" class="form-control" value="<?php echo $penulis['tanggal_lahir'];?>">
        </div>
    </div>
    <div class="form-group">
        <label class="col-lg-2 control-label">Domisili</label>
        <div class="col-lg-5">
            <input type="text" name="domisili" class="form-control" value="<?php echo $penulis['domisili'];?>">
        </div>
    </div>

    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Update</button>
        <a href="<?php echo site_url('CAdmin/Penulis');?>" class="btn btn-default">Kembali</a>
    </div>
</form>
