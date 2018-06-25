<a href="<?php echo site_url('CAdmin/TambahPenerbit');?>" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i> Tambah</a>
<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Nama</td>
            <td>Lokasi Percetakan</td>
            <td>No Telepon</td>
            <td colspan="2"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($penerbit as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->nama_penerbit;?></td>
        <td><?php echo $row->lokasipercetakan;?></td>
        <td><?php echo $row->notelepon;?></td>
        <td><a href="<?php echo site_url('CAdmin/EditPenerbit/'.$row->id_penerbit);?>"><i class="glyphicon glyphicon-edit"></i></a></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_penerbit;?>"><i class="glyphicon glyphicon-trash"></i></a></td>
    </tr>
    <?php endforeach;?>
</Table>
<?php echo $pagination;?>

<script>
    $(function(){
        $(".hapus").click(function(){
            var kode=$(this).attr("kode");
            
            $("#idhapus").val(kode);
            $("#myModal").modal("show");
        });
        
        $("#konfirmasi").click(function(){
            var kode=$("#idhapus").val();
            
            $.ajax({
                url:"<?php echo site_url('CAdmin/Hapus/Penerbit');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Penerbit/delete_success');?>";
                }
            });
        });
    });
</script>
