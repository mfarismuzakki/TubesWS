<a href="<?php echo site_url('CAdmin/TambahDeskripsi');?>" class="btn btn-primary"><i class="glyphicon glyphicon-plus"></i> Tambah</a>
<hr>
<?php echo $message;?>
<Table class="table table-striped">
    <thead>
        <tr>
            <td>No.</td>
            <td>Isi</td>
            <td>Id Buku</td>
            <td colspan="2"></td>
        </tr>
    </thead>
    <?php $no=0; foreach($deskripsi as $row ): $no++;?>
    <tr>
        <td><?php echo $no;?></td>
        <td><?php echo $row->isi;?></td>
        <td><?php echo $row->id_buku;?></td>
        <td><a href="<?php echo site_url('CAdmin/EditDeskripsi/'.$row->id_deskripsi);?>"><i class="glyphicon glyphicon-edit"></i></a></td>
        <td><a href="#" class="hapus" kode="<?php echo $row->id_deskripsi;?>"><i class="glyphicon glyphicon-trash"></i></a></td>
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
                url:"<?php echo site_url('CAdmin/Hapus/Deskripsi');?>",
                type:"POST",
                data:"id="+kode,
                cache:false,
                success:function(html){
                    location.href="<?php echo site_url('CAdmin/Deskripsi/delete_success');?>";
                }
            });
        });
    });
</script>
