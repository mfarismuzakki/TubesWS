<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/EditKategori/'.$kategori['id_kategori']);?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Nama Kategori</label>
        <div class="col-lg-5">
            <input type="text" name="nama_kategori" class="form-control" value="<?php echo $kateogori['nama_kategori'];?>">
        </div>
    </div>
   

    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Update</button>
        <a href="<?php echo site_url('CAdmin/Kategori');?>" class="btn btn-default">Kembali</a>
    </div>
</form>
