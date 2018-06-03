<legend><?php echo $title;?></legend>
<?php echo validation_errors();?>
<?php echo $message;?>

<form class="form-horizontal" action="<?php echo site_url('CAdmin/EditDeskripsi/'.$deskripsi['id_deskripsi']);?>" method="post" enctype="multipart/form-data">
    <div class="form-group">
        <label class="col-lg-2 control-label">Isi</label>
        <div class="col-lg-5">
            <input type="text" name="isi" class="form-control" value="<?php echo $deskripsi['isi'];?>">
        </div>
    </div>
    
    <div class="form-group">
        <label class="col-lg-2 control-label">Id Buku</label>
        <div class="col-lg-5">
            <input type="text" name="id_buku" class="form-control" value="<?php echo $deskripsi['id_buku'];?>">
        </div>
    </div>   

    <div class="form-group well">
        <button class="btn btn-primary"><i class="glyphicon glyphicon-hdd"></i> Update</button>
        <a href="<?php echo site_url('CAdmin/Deskripsi');?>" class="btn btn-default">Kembali</a>
    </div>
</form>
