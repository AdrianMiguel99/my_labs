import axios from "axios";

<template>
    <div class="d-flex justify-content-center alighn-items-center vh-100">
        <div class="card p-4 shadow" style="max-width: 400px; width:100%">
            <h3 class="text-center">Formulario de creacion de paises</h3>
            <form @submit.prevent="saveCountry">
                <div class="form-group">
                    <label for="nombre">Nombre</label>
                    <input
                        v-model="formData.name"
                        type="text"
                        id="name"
                        class="form-control"
                        required
                    />
                </div>

                <div class="form-group">
                    <label for="continente">Continente</label>
                    <select
                        v-model="formData.continent"
                        id="continente"
                        required
                        class="form-control"
                    >
                        <option value="" disabled>Seleccione un continente</option>
                        <option>Africa</option>
                        <option>Asia</option>
                        <option>Europa</option>
                        <option>America</option>
                        <option>Oceania</option>
                        <option>Antartida</option>
                    </select>
                </div>

                <div class="form-group">
                    <label for="idioma">Idioma</label>
                    <input
                        v-model="formData.language"
                        type="text"
                        id="idioma"
                        class="form-control"
                        required
                    />    
                </div>
                
                <div>
                    <button type="submit" class="btn btn-success btn-block">
                        Guardar
                    </button>
                </div>
            </form>
        </div>
    </div>
</template>

<script>
import axios from 'axios';

    export default {
        data() {
            return {
                formData: {
                    name: "",
                    continent: "",
                    language: ""
                },
            };
        },
        methods: {
            saveCountry() {
                axios
                    .post("https://localhost:7029/api/Country", {
                        Name: this.formData.name,
                        Continent: this.formData.continent,
                        Language: this.formData.language

                    })
                    .then(function(response) {
                        console.log(response);
                        window.location.href = "/";
                    })
                    .catch(function(error) {
                        console.error(error);
                    });
                console.log("Datos a guardar:", this.formData);
            },
        },
    }
    
</script>

<style></style>