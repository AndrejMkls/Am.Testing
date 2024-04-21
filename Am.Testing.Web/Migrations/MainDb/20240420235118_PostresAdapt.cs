using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Am.Testing.Web.Migrations.MainDb
{
    /// <inheritdoc />
    public partial class PostresAdapt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_author_book_BookId",
                schema: "public",
                table: "author");

            migrationBuilder.DropForeignKey(
                name: "FK_book_Publishers_PublisherId",
                schema: "public",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_cover_type_CoverTypeId",
                schema: "public",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_book_BookId",
                schema: "public",
                table: "book_genre");

            migrationBuilder.DropIndex(
                name: "IX_author_BookId",
                schema: "public",
                table: "author");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "public",
                table: "book_genre");

            migrationBuilder.DropColumn(
                name: "BookId",
                schema: "public",
                table: "author");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "publisher",
                newSchema: "public");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "public",
                table: "cover_type",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "cover_type",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "public",
                table: "cover_type",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "cover_type",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                schema: "public",
                table: "cover_type",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "cover_type",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "public",
                table: "cover_type",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "cover_type",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "public",
                table: "book_genre",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "book_genre",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                schema: "public",
                table: "book_genre",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "book_genre",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "public",
                table: "book_genre",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "book_genre",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "BookId",
                schema: "public",
                table: "book_genre",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_book_genre_BookId",
                schema: "public",
                table: "book_genre",
                newName: "IX_book_genre_book_id");

            migrationBuilder.RenameColumn(
                name: "Width",
                schema: "public",
                table: "book",
                newName: "width");

            migrationBuilder.RenameColumn(
                name: "Title",
                schema: "public",
                table: "book",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Thickness",
                schema: "public",
                table: "book",
                newName: "thickness");

            migrationBuilder.RenameColumn(
                name: "Summary",
                schema: "public",
                table: "book",
                newName: "summary");

            migrationBuilder.RenameColumn(
                name: "Language",
                schema: "public",
                table: "book",
                newName: "language");

            migrationBuilder.RenameColumn(
                name: "ISBN",
                schema: "public",
                table: "book",
                newName: "isbn");

            migrationBuilder.RenameColumn(
                name: "Height",
                schema: "public",
                table: "book",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "Edition",
                schema: "public",
                table: "book",
                newName: "edition");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "book",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "public",
                table: "book",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "book",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                schema: "public",
                table: "book",
                newName: "publisher_id");

            migrationBuilder.RenameColumn(
                name: "PublicationDate",
                schema: "public",
                table: "book",
                newName: "publication_date");

            migrationBuilder.RenameColumn(
                name: "PageCount",
                schema: "public",
                table: "book",
                newName: "page_count");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                schema: "public",
                table: "book",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "book",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "public",
                table: "book",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "book",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "CoverTypeId",
                schema: "public",
                table: "book",
                newName: "cover_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_book_PublisherId",
                schema: "public",
                table: "book",
                newName: "IX_book_publisher_id");

            migrationBuilder.RenameIndex(
                name: "IX_book_CoverTypeId",
                schema: "public",
                table: "book",
                newName: "IX_book_cover_type_id");

            migrationBuilder.RenameColumn(
                name: "Photo",
                schema: "public",
                table: "author",
                newName: "photo");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                schema: "public",
                table: "author",
                newName: "nationality");

            migrationBuilder.RenameColumn(
                name: "Biography",
                schema: "public",
                table: "author",
                newName: "biography");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "author",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "public",
                table: "author",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "author",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "public",
                table: "author",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FullName",
                schema: "public",
                table: "author",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "public",
                table: "author",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                schema: "public",
                table: "author",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "author",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "public",
                table: "author",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "author",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "BirthYear",
                schema: "public",
                table: "author",
                newName: "birth_year");

            migrationBuilder.RenameColumn(
                name: "Website",
                schema: "public",
                table: "publisher",
                newName: "website");

            migrationBuilder.RenameColumn(
                name: "Notes",
                schema: "public",
                table: "publisher",
                newName: "notes");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "public",
                table: "publisher",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "public",
                table: "publisher",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "public",
                table: "publisher",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "YearFounded",
                schema: "public",
                table: "publisher",
                newName: "year_founded");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                schema: "public",
                table: "publisher",
                newName: "updated_by");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                schema: "public",
                table: "publisher",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "PublisherType",
                schema: "public",
                table: "publisher",
                newName: "publisher_type");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                schema: "public",
                table: "publisher",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                schema: "public",
                table: "publisher",
                newName: "deleted_by");

            migrationBuilder.RenameColumn(
                name: "DeletedAt",
                schema: "public",
                table: "publisher",
                newName: "deleted_at");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "public",
                table: "publisher",
                newName: "created_by");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                schema: "public",
                table: "publisher",
                newName: "created_at");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "public",
                table: "cover_type",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "book_id",
                schema: "public",
                table: "book_genre",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "genre_id",
                schema: "public",
                table: "book_genre",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                schema: "public",
                table: "book",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "summary",
                schema: "public",
                table: "book",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "language",
                schema: "public",
                table: "book",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "isbn",
                schema: "public",
                table: "book",
                type: "character varying(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "edition",
                schema: "public",
                table: "book",
                type: "character varying(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nationality",
                schema: "public",
                table: "author",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                schema: "public",
                table: "author",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "full_name",
                schema: "public",
                table: "author",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                schema: "public",
                table: "author",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "website",
                schema: "public",
                table: "publisher",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                schema: "public",
                table: "publisher",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                schema: "public",
                table: "publisher",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "publisher_type",
                schema: "public",
                table: "publisher",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                schema: "public",
                table: "publisher",
                type: "character varying(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_publisher",
                schema: "public",
                table: "publisher",
                column: "id");

            migrationBuilder.CreateTable(
                name: "book_author",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    author_id = table.Column<long>(type: "bigint", nullable: false),
                    book_id = table.Column<long>(type: "bigint", nullable: false),
                    created_by = table.Column<string>(type: "text", nullable: true),
                    updated_by = table.Column<string>(type: "text", nullable: true),
                    deleted_by = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_book_author_author_author_id",
                        column: x => x.author_id,
                        principalSchema: "public",
                        principalTable: "author",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_book_author_book_book_id",
                        column: x => x.book_id,
                        principalSchema: "public",
                        principalTable: "book",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "genre",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    created_by = table.Column<string>(type: "text", nullable: true),
                    updated_by = table.Column<string>(type: "text", nullable: true),
                    deleted_by = table.Column<string>(type: "text", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genre", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_genre_genre_id",
                schema: "public",
                table: "book_genre",
                column: "genre_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_author_author_id",
                schema: "public",
                table: "book_author",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_author_book_id",
                schema: "public",
                table: "book_author",
                column: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_book_cover_type_cover_type_id",
                schema: "public",
                table: "book",
                column: "cover_type_id",
                principalSchema: "public",
                principalTable: "cover_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_publisher_publisher_id",
                schema: "public",
                table: "book",
                column: "publisher_id",
                principalSchema: "public",
                principalTable: "publisher",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_book_book_id",
                schema: "public",
                table: "book_genre",
                column: "book_id",
                principalSchema: "public",
                principalTable: "book",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_genre_genre_id",
                schema: "public",
                table: "book_genre",
                column: "genre_id",
                principalSchema: "public",
                principalTable: "genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_cover_type_cover_type_id",
                schema: "public",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_publisher_publisher_id",
                schema: "public",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_book_book_id",
                schema: "public",
                table: "book_genre");

            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_genre_genre_id",
                schema: "public",
                table: "book_genre");

            migrationBuilder.DropTable(
                name: "book_author",
                schema: "public");

            migrationBuilder.DropTable(
                name: "genre",
                schema: "public");

            migrationBuilder.DropIndex(
                name: "IX_book_genre_genre_id",
                schema: "public",
                table: "book_genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_publisher",
                schema: "public",
                table: "publisher");

            migrationBuilder.DropColumn(
                name: "genre_id",
                schema: "public",
                table: "book_genre");

            migrationBuilder.RenameTable(
                name: "publisher",
                schema: "public",
                newName: "Publishers");

            migrationBuilder.RenameColumn(
                name: "name",
                schema: "public",
                table: "cover_type",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "cover_type",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                schema: "public",
                table: "cover_type",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "cover_type",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                schema: "public",
                table: "cover_type",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "cover_type",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                schema: "public",
                table: "cover_type",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "cover_type",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                schema: "public",
                table: "book_genre",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "book_genre",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                schema: "public",
                table: "book_genre",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "book_genre",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                schema: "public",
                table: "book_genre",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "book_genre",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "book_id",
                schema: "public",
                table: "book_genre",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_book_genre_book_id",
                schema: "public",
                table: "book_genre",
                newName: "IX_book_genre_BookId");

            migrationBuilder.RenameColumn(
                name: "width",
                schema: "public",
                table: "book",
                newName: "Width");

            migrationBuilder.RenameColumn(
                name: "title",
                schema: "public",
                table: "book",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "thickness",
                schema: "public",
                table: "book",
                newName: "Thickness");

            migrationBuilder.RenameColumn(
                name: "summary",
                schema: "public",
                table: "book",
                newName: "Summary");

            migrationBuilder.RenameColumn(
                name: "language",
                schema: "public",
                table: "book",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "isbn",
                schema: "public",
                table: "book",
                newName: "ISBN");

            migrationBuilder.RenameColumn(
                name: "height",
                schema: "public",
                table: "book",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "edition",
                schema: "public",
                table: "book",
                newName: "Edition");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "book",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                schema: "public",
                table: "book",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "book",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "publisher_id",
                schema: "public",
                table: "book",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "publication_date",
                schema: "public",
                table: "book",
                newName: "PublicationDate");

            migrationBuilder.RenameColumn(
                name: "page_count",
                schema: "public",
                table: "book",
                newName: "PageCount");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                schema: "public",
                table: "book",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "book",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                schema: "public",
                table: "book",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "book",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "cover_type_id",
                schema: "public",
                table: "book",
                newName: "CoverTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_book_publisher_id",
                schema: "public",
                table: "book",
                newName: "IX_book_PublisherId");

            migrationBuilder.RenameIndex(
                name: "IX_book_cover_type_id",
                schema: "public",
                table: "book",
                newName: "IX_book_CoverTypeId");

            migrationBuilder.RenameColumn(
                name: "photo",
                schema: "public",
                table: "author",
                newName: "Photo");

            migrationBuilder.RenameColumn(
                name: "nationality",
                schema: "public",
                table: "author",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "biography",
                schema: "public",
                table: "author",
                newName: "Biography");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "public",
                table: "author",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                schema: "public",
                table: "author",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                schema: "public",
                table: "author",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "last_name",
                schema: "public",
                table: "author",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "full_name",
                schema: "public",
                table: "author",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                schema: "public",
                table: "author",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                schema: "public",
                table: "author",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                schema: "public",
                table: "author",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                schema: "public",
                table: "author",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                schema: "public",
                table: "author",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "birth_year",
                schema: "public",
                table: "author",
                newName: "BirthYear");

            migrationBuilder.RenameColumn(
                name: "website",
                table: "Publishers",
                newName: "Website");

            migrationBuilder.RenameColumn(
                name: "notes",
                table: "Publishers",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Publishers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Publishers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Publishers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "year_founded",
                table: "Publishers",
                newName: "YearFounded");

            migrationBuilder.RenameColumn(
                name: "updated_by",
                table: "Publishers",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "Publishers",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "publisher_type",
                table: "Publishers",
                newName: "PublisherType");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "Publishers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "deleted_by",
                table: "Publishers",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "deleted_at",
                table: "Publishers",
                newName: "DeletedAt");

            migrationBuilder.RenameColumn(
                name: "created_by",
                table: "Publishers",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "Publishers",
                newName: "CreatedAt");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "cover_type",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<long>(
                name: "BookId",
                schema: "public",
                table: "book_genre",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "public",
                table: "book_genre",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                schema: "public",
                table: "book",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Summary",
                schema: "public",
                table: "book",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                schema: "public",
                table: "book",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                schema: "public",
                table: "book",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Edition",
                schema: "public",
                table: "book",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nationality",
                schema: "public",
                table: "author",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "public",
                table: "author",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                schema: "public",
                table: "author",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "public",
                table: "author",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<long>(
                name: "BookId",
                schema: "public",
                table: "author",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "Publishers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publishers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Publishers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PublisherType",
                table: "Publishers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Publishers",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_author_BookId",
                schema: "public",
                table: "author",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_author_book_BookId",
                schema: "public",
                table: "author",
                column: "BookId",
                principalSchema: "public",
                principalTable: "book",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_book_Publishers_PublisherId",
                schema: "public",
                table: "book",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_cover_type_CoverTypeId",
                schema: "public",
                table: "book",
                column: "CoverTypeId",
                principalSchema: "public",
                principalTable: "cover_type",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_book_BookId",
                schema: "public",
                table: "book_genre",
                column: "BookId",
                principalSchema: "public",
                principalTable: "book",
                principalColumn: "Id");
        }
    }
}
